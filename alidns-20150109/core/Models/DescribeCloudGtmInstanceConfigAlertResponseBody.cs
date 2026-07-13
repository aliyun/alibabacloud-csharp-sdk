// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmInstanceConfigAlertResponseBody : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfig AlertConfig { get; set; }
        public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfigAlertConfig> AlertConfig { get; set; }
            public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfigAlertConfig : TeaModel {
                [NameInMap("DingtalkNotice")]
                [Validation(Required=false)]
                public bool? DingtalkNotice { get; set; }

                [NameInMap("EmailNotice")]
                [Validation(Required=false)]
                public bool? EmailNotice { get; set; }

                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                [NameInMap("SmsNotice")]
                [Validation(Required=false)]
                public bool? SmsNotice { get; set; }

            }

        }

        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public DescribeCloudGtmInstanceConfigAlertResponseBodyAlertGroup AlertGroup { get; set; }
        public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertGroup : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<string> AlertGroup { get; set; }

        }

        /// <summary>
        /// <para>The alert configuration mode for the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>global: The instance inherits the global alert configuration.</para>
        /// </description></item>
        /// <item><description><para>instance_config: The instance uses a custom alert configuration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        /// <summary>
        /// <para>The ID of the instance configuration. For the same access domain name and GTM instance, you can configure both A and AAAA records. This creates two instance configurations. \<c>ConfigId\\</c> uniquely identifies an instance configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000**11</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F32959D-417B-4D66-8463-68606605E3E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
