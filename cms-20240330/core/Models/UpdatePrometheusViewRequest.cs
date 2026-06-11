// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdatePrometheusViewRequest : TeaModel {
        /// <summary>
        /// <para>The policy for password-free read access. IP address segments and VPC IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;SourceIp&quot;: [
        ///     &quot;192.168.1.0/24&quot;,
        ///     &quot;172.168.2.22&quot;
        ///   ],
        ///   &quot;SourceVpc&quot;: [
        ///     &quot;vpc-xx1&quot;,
        ///     &quot;vpc-xx2&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("authFreeReadPolicy")]
        [Validation(Required=false)]
        public string AuthFreeReadPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-free read access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>A list of Prometheus instances.</para>
        /// </summary>
        [NameInMap("prometheusInstances")]
        [Validation(Required=false)]
        public List<UpdatePrometheusViewRequestPrometheusInstances> PrometheusInstances { get; set; }
        public class UpdatePrometheusViewRequestPrometheusInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c7ba84651c71e442c8d0653085d862164</para>
            /// </summary>
            [NameInMap("prometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-north-2-gov-1</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16727123456789</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The name of the Prometheus view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-prom-view-name</para>
        /// </summary>
        [NameInMap("prometheusViewName")]
        [Validation(Required=false)]
        public string PrometheusViewName { get; set; }

        /// <summary>
        /// <para>The status of the Prometheus view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The workspace to which the view belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-108490012345-cn-heyuan</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
