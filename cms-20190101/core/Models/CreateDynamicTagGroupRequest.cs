// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateDynamicTagGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public List<string> ContactGroupList { get; set; }

        /// <summary>
        /// Specifies whether the CloudMonitor agent is automatically installed for the application group. CloudMonitor determines whether to automatically install the CloudMonitor agent for the hosts in an application group based on the value of this parameter. Valid values:
        /// 
        /// *   true: The CloudMonitor agent is automatically installed.
        /// *   false (default value): The CloudMonitor agent is not automatically installed.
        /// </summary>
        [NameInMap("EnableInstallAgent")]
        [Validation(Required=false)]
        public bool? EnableInstallAgent { get; set; }

        /// <summary>
        /// Specifies whether the application group automatically subscribes to event notifications. If events whose severity level is critical or warning occur on resources in an application group, CloudMonitor sends alert notifications. Valid values:
        /// 
        /// *   true: The application group automatically subscribes to event notifications.
        /// *   false (default value): The application group does not automatically subscribe to event notifications.
        /// </summary>
        [NameInMap("EnableSubscribeEvent")]
        [Validation(Required=false)]
        public bool? EnableSubscribeEvent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateDynamicTagGroupRequestMatchExpress> MatchExpress { get; set; }
        public class CreateDynamicTagGroupRequestMatchExpress : TeaModel {
            /// <summary>
            /// The keys of the tags that are used to create the application group. If a specified key is attached to multiple resources, the resources that have the same key-value pair are added to the same group.
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// The tag values of the cloud resources. In this example, set the value of N to 1.
            /// 
            /// >  If you set the `MatchExpress.N.TagValueMatchFunction` parameter, you must also set the `MatchExpress.N.TagValue` parameter.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// The method that is used to match the tag values of the cloud resources. In this example, set the value of N to 1. Valid values:
            /// 
            /// *   contains: contains
            /// *   startWith: starts with a prefix
            /// *   endWith: ends with a suffix
            /// *   notContains: does not contain
            /// *   equals: equals
            /// *   all: matches all
            /// 
            /// >  If you set the `MatchExpress.N.TagValueMatchFunction` parameter, you must also set the `MatchExpress.N.TagValue` parameter.
            /// </summary>
            [NameInMap("TagValueMatchFunction")]
            [Validation(Required=false)]
            public string TagValueMatchFunction { get; set; }

        }

        /// <summary>
        /// The relationship between the conditional expressions for the tag values of the cloud resources. Valid values:
        /// 
        /// *   and (default value)
        /// *   or
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tag keys of the cloud resources.
        /// 
        /// For more information about how to obtain tag keys, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145558.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// The ID of the region to which the tags belong.
        /// </summary>
        [NameInMap("TagRegionId")]
        [Validation(Required=false)]
        public string TagRegionId { get; set; }

        [NameInMap("TemplateIdList")]
        [Validation(Required=false)]
        public List<string> TemplateIdList { get; set; }

    }

}
