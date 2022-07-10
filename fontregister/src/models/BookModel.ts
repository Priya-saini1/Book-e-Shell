export class BookModel {
	id?: number;
	name!: string;
	price!: string;
	categoryId!: number;
	category?: string;
	description!: string;
	base64Image!: string;
	publisherId?: number;
	quantity?: number;
}
