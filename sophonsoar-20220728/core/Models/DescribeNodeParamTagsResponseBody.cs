// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeNodeParamTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The recommended path configurations.</para>
        /// </summary>
        [NameInMap("ParamReferredPaths")]
        [Validation(Required=false)]
        public List<DescribeNodeParamTagsResponseBodyParamReferredPaths> ParamReferredPaths { get; set; }
        public class DescribeNodeParamTagsResponseBodyParamReferredPaths : TeaModel {
            /// <summary>
            /// <para>The name of the ancestor node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataFormat_1</para>
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            /// <summary>
            /// <para>An array of paths.</para>
            /// </summary>
            [NameInMap("ReferredPath")]
            [Validation(Required=false)]
            public List<string> ReferredPath { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates this unique ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BE94351-712A-505D-A40A-BC77CC8254A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
