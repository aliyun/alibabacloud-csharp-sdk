// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The commodity codes. Separate multiple codes with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmgj000112,cmgj000113</para>
        /// </summary>
        [NameInMap("Codes")]
        [Validation(Required=false)]
        public string Codes { get; set; }

        /// <summary>
        /// <para>The commodity codes to exclude. This parameter cannot be specified together with the Codes parameter. Separate multiple codes with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmgj000114,cmgj000115</para>
        /// </summary>
        [NameInMap("ExceptCodes")]
        [Validation(Required=false)]
        public string ExceptCodes { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The commodity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APP: application</description></item>
        /// <item><description>SERVICE: service</description></item>
        /// <item><description>MIRROR: image</description></item>
        /// <item><description>DOWNLOAD: download</description></item>
        /// <item><description>API_SERVICE: API</description></item>
        /// <item><description>ROS: resource orchestration</description></item>
        /// <item><description>DOCKER: container</description></item>
        /// <item><description>IOT: IoT.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
