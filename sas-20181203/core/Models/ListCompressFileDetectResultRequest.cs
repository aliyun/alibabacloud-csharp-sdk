// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCompressFileDetectResultRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The identifier of the file. Only MD5 hash values are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a212417e65c26ff133cfff28f6c****</para>
        /// </summary>
        [NameInMap("HashKey")]
        [Validation(Required=false)]
        public string HashKey { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.9.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
