// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetPostScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to obtain the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-sh-EnjshUxn</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The post-processing scripts.</para>
        /// </summary>
        [NameInMap("PostInstallScripts")]
        [Validation(Required=false)]
        public List<SetPostScriptsRequestPostInstallScripts> PostInstallScripts { get; set; }
        public class SetPostScriptsRequestPostInstallScripts : TeaModel {
            /// <summary>
            /// <para>The parameter that is used to run the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-h</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://bucket.oss-cn-shanghai.aliyuncs.com/postscript_examples.sh">https://bucket.oss-cn-shanghai.aliyuncs.com/postscript_examples.sh</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region where the cluster resides. You can call the <a href="https://help.aliyun.com/document_detail/188593.html">ListRegions</a> operation to query the latest region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
