// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudServerRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudServerRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeHybridCloudServerRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The code of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FBBDE11-C35F-531B-96BA-64CA****C875</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
