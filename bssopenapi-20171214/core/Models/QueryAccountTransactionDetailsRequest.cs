// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the creation time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-20</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the creation time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-20</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>This parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABEDSDS124DASA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the order or bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022120336190912</para>
        /// </summary>
        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        /// <summary>
        /// <para>The transaction channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIPAY</para>
        /// </summary>
        [NameInMap("TransactionChannel")]
        [Validation(Required=false)]
        public string TransactionChannel { get; set; }

        /// <summary>
        /// <para>The serial number of the transaction channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022112122001470591458665933</para>
        /// </summary>
        [NameInMap("TransactionChannelSN")]
        [Validation(Required=false)]
        public string TransactionChannelSN { get; set; }

        /// <summary>
        /// <para>The number of the transaction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>410874027490089</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public string TransactionNumber { get; set; }

        /// <summary>
        /// <para>The type of the transaction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHARGE</para>
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

    }

}
