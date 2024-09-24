// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8BF6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the details of the configuration items.</para>
        /// </summary>
        [NameInMap("TargetList")]
        [Validation(Required=false)]
        public List<DescribeCommonTargetConfigResponseBodyTargetList> TargetList { get; set; }
        public class DescribeCommonTargetConfigResponseBodyTargetList : TeaModel {
            /// <summary>
            /// <para>The mode in which the configuration takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: In this mode, the configuration takes effect on the assets.</description></item>
            /// <item><description><b>del</b>: In this mode, the configuration does not take effect on the assets.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The ID of the asset on which the configuration takes effect.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>When you set the <b>TargetType</b> parameter to <b>uuid</b>, the value of this parameter indicates the UUID of an asset.</para>
            /// </description></item>
            /// <item><description><para>When you set the <b>TargetType</b> parameter to <b>Cluster</b>, the value of this parameter indicates the ID of a cluster.</para>
            /// </description></item>
            /// <item><description><para>When you set the <b>TargetType</b> parameter to <b>image_repo</b>, the value of this parameter indicates the ID of an image repository.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c23551de6149343e8a54e69fbefe6****</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The dimension from on which the feature was configured. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>uuid</b>: the UUID of the asset</description></item>
            /// <item><description><b>Cluster</b>: the ID of the cluster</description></item>
            /// <item><description><b>image_repo</b>: the ID of the image repository</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image_repo</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
