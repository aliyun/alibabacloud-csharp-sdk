// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateDynamicTagGroupRequest : TeaModel {
        /// <summary>
        /// The relationship between the conditional expressions for the tag values of the cloud resources. Valid values:
        /// 
        /// *   and (default)
        /// *   or
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public List<string> ContactGroupList { get; set; }

        /// <summary>
        /// The ID of the region to which the tags belong.
        /// </summary>
        [NameInMap("EnableInstallAgent")]
        [Validation(Required=false)]
        public bool? EnableInstallAgent { get; set; }

        /// <summary>
        /// The keys of the tags that are used to create the application group. If a specified key is attached to multiple resources, the resources that have the same key-value pair are added to the same group.
        /// </summary>
        [NameInMap("EnableSubscribeEvent")]
        [Validation(Required=false)]
        public bool? EnableSubscribeEvent { get; set; }

        /// <summary>
        /// Specifies whether the CloudMonitor agent is automatically installed for the application group. CloudMonitor determines whether to automatically install the CloudMonitor agent for the hosts in an application group based on the value of this parameter. Valid values:
        /// 
        /// *   true: The CloudMonitor agent is automatically installed.
        /// *   false (default): The CloudMonitor agent is not automatically installed.
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateDynamicTagGroupRequestMatchExpress> MatchExpress { get; set; }
        public class CreateDynamicTagGroupRequestMatchExpress : TeaModel {
            /// <summary>
            /// The tag values of the cloud resources. In this example, set the value of N to 1.
            /// 
            /// >  If you set the `MatchExpress.N.TagValueMatchFunction` parameter, you must also set the `MatchExpress.N.TagValue` parameter.
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// The ID of the region to which the tags belong.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("TagValueMatchFunction")]
            [Validation(Required=false)]
            public string TagValueMatchFunction { get; set; }

        }

        /// <summary>
        /// Specifies whether the application group automatically subscribes to event notifications. If events whose severity level is critical or warning occur on resources in an application group, CloudMonitor sends alert notifications. Valid values:
        /// 
        /// *   true: The application group automatically subscribes to event notifications.
        /// *   false (default): The application group does not automatically subscribe to event notifications.
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The alert contact groups. Valid values of N: 1 to 100. The alert notifications of the application group are sent to the alert contacts that belong to the specified alert contact groups.
        /// 
        /// An alert contact group can contain one or more alert contacts. For information about how to create alert contacts and alert contact groups, see [PutContact](~~114923~~) and [PutContactGroup](~~114929~~). For information about how to obtain alert contact groups, see [DescribeContactGroupList](~~114922~~).
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// The tag keys of the cloud resources.
        /// 
        /// For more information about how to obtain tag keys, see [DescribeTagKeyList](~~145558~~).
        /// </summary>
        [NameInMap("TagRegionId")]
        [Validation(Required=false)]
        public string TagRegionId { get; set; }

        /// <summary>
        /// The IDs of the alert templates.
        /// 
        /// For more information about how to query alert template IDs, see [DescribeMetricRuleTemplateList](~~114982~~).
        /// </summary>
        [NameInMap("TemplateIdList")]
        [Validation(Required=false)]
        public List<string> TemplateIdList { get; set; }

    }

}
