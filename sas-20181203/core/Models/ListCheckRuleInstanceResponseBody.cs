// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckRuleInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103784262032****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <para>Subtype of the cloud product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disk</para>
        /// </summary>
        [NameInMap("AssetSubType")]
        [Validation(Required=false)]
        public string AssetSubType { get; set; }

        /// <summary>
        /// <para>Type of cloud assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>Check item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// <para>List of instance rule information.</para>
        /// </summary>
        [NameInMap("CheckRuleInstances")]
        [Validation(Required=false)]
        public List<ListCheckRuleInstanceResponseBodyCheckRuleInstances> CheckRuleInstances { get; set; }
        public class ListCheckRuleInstanceResponseBodyCheckRuleInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6c76lh1kvrcvwl*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testEcs</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the current request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Cloud vendor. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
        /// <item><description><b>TENCENT</b>: Tencent Cloud</description></item>
        /// <item><description><b>MICROSOFT</b>: Microsoft</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
