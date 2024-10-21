// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferInListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("SimpleTransferInStatus")]
        [Validation(Required=false)]
        public string SimpleTransferInStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("SubmissionEndDate")]
        [Validation(Required=false)]
        public long? SubmissionEndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("SubmissionStartDate")]
        [Validation(Required=false)]
        public long? SubmissionStartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
