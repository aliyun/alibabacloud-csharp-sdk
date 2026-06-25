// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Group : TeaModel {
        /// <summary>
        /// <para>The access token for the traffic entry of the service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MzJiMDI5MDliODc0MTlkYmI0ZDhlYmExYjczYTIyZTE3Zm********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <para>The region in which the service group resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The time when the service group was created. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-19T14:19:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The public endpoint of the service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://1110*****.cn-hangzhou.pai-eas.aliyuncs.com/api/predict/test_group">http://1110*****.cn-hangzhou.pai-eas.aliyuncs.com/api/predict/test_group</a></para>
        /// </summary>
        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        /// <summary>
        /// <para>The internal endpoint of the service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://1110*****.vpc.cn-hangzhou.pai-eas.aliyuncs.com/api/predict/test_group">http://1110*****.vpc.cn-hangzhou.pai-eas.aliyuncs.com/api/predict/test_group</a></para>
        /// </summary>
        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GroupLabels> Labels { get; set; }
        public class GroupLabels : TeaModel {
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            [NameInMap("LabelValue")]
            [Validation(Required=false)]
            public string LabelValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public GroupNetwork Network { get; set; }
        public class GroupNetwork : TeaModel {
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        /// <summary>
        /// <para>The queue services contained in the service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qservice</para>
        /// </summary>
        [NameInMap("QueueService")]
        [Validation(Required=false)]
        public string QueueService { get; set; }

        /// <summary>
        /// <para>The traffic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("TrafficMode")]
        [Validation(Required=false)]
        public string TrafficMode { get; set; }

        /// <summary>
        /// <para>The time when the service group was last updated. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-29T11:13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
