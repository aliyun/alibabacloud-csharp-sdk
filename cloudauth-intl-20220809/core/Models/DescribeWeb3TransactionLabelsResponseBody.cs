// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeWeb3TransactionLabelsResponseBody : TeaModel {
        /// <summary>
        /// Return code. For the full list of codes, see Codes and Messages.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWeb3TransactionLabelsResponseBodyData Data { get; set; }
        public class DescribeWeb3TransactionLabelsResponseBodyData : TeaModel {
            /// <summary>
            /// the amount of native currency
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// chainName
            /// </summary>
            [NameInMap("ChainName")]
            [Validation(Required=false)]
            public string ChainName { get; set; }

            /// <summary>
            /// short name of blockchain
            /// </summary>
            [NameInMap("ChainShortName")]
            [Validation(Required=false)]
            public string ChainShortName { get; set; }

            /// <summary>
            /// contract details
            /// </summary>
            [NameInMap("ContractDetails")]
            [Validation(Required=false)]
            public List<DescribeWeb3TransactionLabelsResponseBodyDataContractDetails> ContractDetails { get; set; }
            public class DescribeWeb3TransactionLabelsResponseBodyDataContractDetails : TeaModel {
                /// <summary>
                /// the value of internal transaction
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// the sender of internal transaction
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// the gaslimit of internal transaction
                /// </summary>
                [NameInMap("GasLimit")]
                [Validation(Required=false)]
                public int? GasLimit { get; set; }

                /// <summary>
                /// the call layer of internal transaction
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// the receiver of internal transaction
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// error log
            /// </summary>
            [NameInMap("ErrorLog")]
            [Validation(Required=false)]
            public string ErrorLog { get; set; }

            /// <summary>
            /// gasLimit
            /// </summary>
            [NameInMap("GasLimit")]
            [Validation(Required=false)]
            public int? GasLimit { get; set; }

            /// <summary>
            /// gasPrice
            /// </summary>
            [NameInMap("GasPrice")]
            [Validation(Required=false)]
            public string GasPrice { get; set; }

            /// <summary>
            /// gasUsed
            /// </summary>
            [NameInMap("GasUsed")]
            [Validation(Required=false)]
            public int? GasUsed { get; set; }

            /// <summary>
            /// height
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// the position of the transaction in the block
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// input data
            /// </summary>
            [NameInMap("InputData")]
            [Validation(Required=false)]
            public string InputData { get; set; }

            /// <summary>
            /// input details
            /// </summary>
            [NameInMap("InputDetails")]
            [Validation(Required=false)]
            public List<DescribeWeb3TransactionLabelsResponseBodyDataInputDetails> InputDetails { get; set; }
            public class DescribeWeb3TransactionLabelsResponseBodyDataInputDetails : TeaModel {
                /// <summary>
                /// example: 15. the amount of transation sent by the address
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// the address hash
                /// </summary>
                [NameInMap("InputHash")]
                [Validation(Required=false)]
                public string InputHash { get; set; }

                /// <summary>
                /// example: true. is it a contract
                /// </summary>
                [NameInMap("IsContract")]
                [Validation(Required=false)]
                public string IsContract { get; set; }

                /// <summary>
                /// example: Dex . the tag of the address
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// the method name of contract call. For external transaction method: [\\"CALL\\",\\"CALLCODE\\",\\"DELEGATECALL\\",\\"STATICCALL\\"]; for internal transaction method: the first 4 bytes of the hash of the method name
            /// </summary>
            [NameInMap("MethodId")]
            [Validation(Required=false)]
            public string MethodId { get; set; }

            /// <summary>
            /// nonce
            /// </summary>
            [NameInMap("Nonce")]
            [Validation(Required=false)]
            public string Nonce { get; set; }

            /// <summary>
            /// output details
            /// </summary>
            [NameInMap("OutputDetails")]
            [Validation(Required=false)]
            public List<DescribeWeb3TransactionLabelsResponseBodyDataOutputDetails> OutputDetails { get; set; }
            public class DescribeWeb3TransactionLabelsResponseBodyDataOutputDetails : TeaModel {
                /// <summary>
                /// example: 15. the amount of transation sent by the address
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// the address hash
                /// </summary>
                [NameInMap("InputHash")]
                [Validation(Required=false)]
                public string InputHash { get; set; }

                /// <summary>
                /// example: true. is it a contract
                /// </summary>
                [NameInMap("IsContract")]
                [Validation(Required=false)]
                public string IsContract { get; set; }

                /// <summary>
                /// example: Dex. the tag of the address
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// the transaction state. 1: success 0: fail
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// token transfer details
            /// </summary>
            [NameInMap("TokenTransferDetails")]
            [Validation(Required=false)]
            public List<DescribeWeb3TransactionLabelsResponseBodyDataTokenTransferDetails> TokenTransferDetails { get; set; }
            public class DescribeWeb3TransactionLabelsResponseBodyDataTokenTransferDetails : TeaModel {
                /// <summary>
                /// the token amount
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// the sender of the token
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// the call layer of to token transfer
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// the token symbol
                /// </summary>
                [NameInMap("Symbol")]
                [Validation(Required=false)]
                public string Symbol { get; set; }

                /// <summary>
                /// the receiver of the token
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

                /// <summary>
                /// the token name
                /// </summary>
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                /// <summary>
                /// the token address
                /// </summary>
                [NameInMap("TokenContractAddress")]
                [Validation(Required=false)]
                public string TokenContractAddress { get; set; }

                /// <summary>
                /// NFT ID, if the token is erc721
                /// </summary>
                [NameInMap("TokenId")]
                [Validation(Required=false)]
                public string TokenId { get; set; }

            }

            /// <summary>
            /// the symbol of native currency
            /// </summary>
            [NameInMap("TransactionSymbol")]
            [Validation(Required=false)]
            public string TransactionSymbol { get; set; }

            /// <summary>
            /// the block timestamp
            /// </summary>
            [NameInMap("TransactionTime")]
            [Validation(Required=false)]
            public string TransactionTime { get; set; }

            /// <summary>
            /// Integer	0: legacy; 1: eip 2930; 2: eip 1559
            /// </summary>
            [NameInMap("TransactionType")]
            [Validation(Required=false)]
            public string TransactionType { get; set; }

            /// <summary>
            /// the transaction fee in eth
            /// </summary>
            [NameInMap("Txfee")]
            [Validation(Required=false)]
            public string Txfee { get; set; }

            /// <summary>
            /// Txid
            /// </summary>
            [NameInMap("Txid")]
            [Validation(Required=false)]
            public string Txid { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Response detailed message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The unique ID of the request, which can be used to locate issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
