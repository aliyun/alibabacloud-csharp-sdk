// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeWeb3AddressLabelsResponseBody : TeaModel {
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
        public DescribeWeb3AddressLabelsResponseBodyData Data { get; set; }
        public class DescribeWeb3AddressLabelsResponseBodyData : TeaModel {
            /// <summary>
            /// address
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// amount of native currency
            /// </summary>
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public string Balance { get; set; }

            /// <summary>
            /// native currency of the chain
            /// </summary>
            [NameInMap("BalanceSymbol")]
            [Validation(Required=false)]
            public string BalanceSymbol { get; set; }

            /// <summary>
            /// ChainNameEnumstring name of blockchain
            /// </summary>
            [NameInMap("ChainName")]
            [Validation(Required=false)]
            public string ChainName { get; set; }

            /// <summary>
            /// ChainShortName
            /// </summary>
            [NameInMap("ChainShortName")]
            [Validation(Required=false)]
            public string ChainShortName { get; set; }

            /// <summary>
            /// 0: EOA; 1: Contract
            /// </summary>
            [NameInMap("ContractAddress")]
            [Validation(Required=false)]
            public string ContractAddress { get; set; }

            /// <summary>
            /// the address of deployer if the current address is a contract, null if the current address is an EOA
            /// </summary>
            [NameInMap("CreateContractAddress")]
            [Validation(Required=false)]
            public string CreateContractAddress { get; set; }

            /// <summary>
            /// contract creation hash if the current address is a contract, null if the current address is an EOA
            /// </summary>
            [NameInMap("CreateContractTransactionHash")]
            [Validation(Required=false)]
            public string CreateContractTransactionHash { get; set; }

            /// <summary>
            /// customized assessment detail
            /// </summary>
            [NameInMap("CustomRiskAssessment")]
            [Validation(Required=false)]
            public string CustomRiskAssessment { get; set; }

            /// <summary>
            /// the first transaction hash sent by the address
            /// </summary>
            [NameInMap("FirstTransactionTime")]
            [Validation(Required=false)]
            public string FirstTransactionTime { get; set; }

            /// <summary>
            /// 0: Not validator; 1: validator
            /// </summary>
            [NameInMap("IsProducerAddress")]
            [Validation(Required=false)]
            public string IsProducerAddress { get; set; }

            /// <summary>
            /// the latest transaction hash sent by the address
            /// </summary>
            [NameInMap("LastTransactionTime")]
            [Validation(Required=false)]
            public string LastTransactionTime { get; set; }

            /// <summary>
            /// the amount of native currency received in 180 days
            /// </summary>
            [NameInMap("ReceiveAmount")]
            [Validation(Required=false)]
            public string ReceiveAmount { get; set; }

            /// <summary>
            /// the amount of native currency sent in 180 days
            /// </summary>
            [NameInMap("SendAmount")]
            [Validation(Required=false)]
            public string SendAmount { get; set; }

            /// <summary>
            /// tag
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// if the address is an erc20 token, returns the token name
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// the number of erc20 tokens involved with current address in 180 days
            /// </summary>
            [NameInMap("TokenAmount")]
            [Validation(Required=false)]
            public int? TokenAmount { get; set; }

            /// <summary>
            /// address of erc20 tokens involved with current address in 180 days
            /// </summary>
            [NameInMap("TokenList")]
            [Validation(Required=false)]
            public string TokenList { get; set; }

            /// <summary>
            /// the number of transactions
            /// </summary>
            [NameInMap("TransactionCount")]
            [Validation(Required=false)]
            public int? TransactionCount { get; set; }

        }

        /// <summary>
        /// The HTTP status code
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
