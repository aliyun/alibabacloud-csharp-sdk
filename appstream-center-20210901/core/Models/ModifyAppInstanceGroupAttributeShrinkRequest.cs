// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupAttributeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string NetworkShrink { get; set; }

        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public string NodePoolShrink { get; set; }

        [NameInMap("PerSessionPerApp")]
        [Validation(Required=false)]
        public bool? PerSessionPerApp { get; set; }

        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        [NameInMap("PreOpenMode")]
        [Validation(Required=false)]
        public string PreOpenMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

    }

}
