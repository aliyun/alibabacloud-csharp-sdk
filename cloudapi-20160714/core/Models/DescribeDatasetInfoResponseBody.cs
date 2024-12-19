// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The dataset info.</para>
        /// </summary>
        [NameInMap("DatasetInfo")]
        [Validation(Required=false)]
        public DescribeDatasetInfoResponseBodyDatasetInfo DatasetInfo { get; set; }
        public class DescribeDatasetInfoResponseBodyDatasetInfo : TeaModel {
            /// <summary>
            /// <para>The creation time (UTC) of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-21T12:58:43Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62b91a790a693238********</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The name of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DatasetName</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <para>The type of the dataset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>JWT_BLOCKING: a JSON Web Token (JWT) blacklist</description></item>
            /// <item><description>IP_WHITELIST_CIDR : an IP address whitelist</description></item>
            /// <item><description>PARAMETER_ACCESS : parameter-based access control</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>JWT_BLOCKING</para>
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// <para>The last modification time (UTC) of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-21T12:58:43Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2C8F75E-EE84-5C64-960F-45C8********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
