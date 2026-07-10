// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeListFaceVerifyInfosRequest : TeaModel {
        /// <summary>
        /// <para>The authentication ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shs414a8b392a3a338abe0504c75c056</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The end time of the authentication query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760716800000</para>
        /// </summary>
        [NameInMap("GmtEnd")]
        [Validation(Required=false)]
        public long? GmtEnd { get; set; }

        /// <summary>
        /// <para>The start time of the authentication query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760112000000</para>
        /// </summary>
        [NameInMap("GmtStart")]
        [Validation(Required=false)]
        public long? GmtStart { get; set; }

        /// <summary>
        /// <para>The current page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000009699</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The authentication status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Authentication passed.</description></item>
        /// <item><description><b>2</b>: Authentication failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
