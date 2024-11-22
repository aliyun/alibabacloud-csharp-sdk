// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BlockObjectRequest : TeaModel {
        /// <summary>
        /// <para>The content to block.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<string> Content { get; set; }

        /// <summary>
        /// <para>The blocking period that you can extend. Set the value to 2year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2year</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>The period of time during which the URL is blocked. Unit: seconds. Specify this parameter if Type is set to block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>864000</para>
        /// </summary>
        [NameInMap("Maxage")]
        [Validation(Required=false)]
        public int? Maxage { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BlockObject</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b></description></item>
        /// <item><description><b>unblock</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
