// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListProhibitedSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The operating system type for which the prohibited software has configured processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The name of the prohibited software.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thunder</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the software prohibition policy. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListProhibitedPolicies~~">ListProhibitedPolicies</a>: Lists software prohibition policies.</description></item>
        /// <item><description><a href="~~CreateProhibitedPolicy~~">CreateProhibitedPolicy</a>: Creates a software prohibition policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pid-5a1e8c3f7b09****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thunder.exe</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The collection of prohibited software IDs. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("SoftwareIds")]
        [Validation(Required=false)]
        public List<ListProhibitedSoftwareRequestSoftwareIds> SoftwareIds { get; set; }
        public class ListProhibitedSoftwareRequestSoftwareIds : TeaModel {
            /// <summary>
            /// <para>Indicates whether the prohibited software is a system built-in prohibited software. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A system built-in prohibited software that is shared across all Alibaba Cloud accounts and cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: Custom prohibited software under the current Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software. You can obtain the value from the following operations:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~ListProhibitedSoftware~~">ListProhibitedSoftware</a>: Lists prohibited software.</description></item>
            /// <item><description><a href="~~CreateProhibitedSoftware~~">CreateProhibitedSoftware</a>: Creates custom prohibited software.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>swb-d9f669a09746****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the prohibited software tag.</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public ListProhibitedSoftwareRequestTagId TagId { get; set; }
        public class ListProhibitedSoftwareRequestTagId : TeaModel {
            /// <summary>
            /// <para>Indicates whether the prohibited software tag is a system built-in tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A system built-in tag that is shared across all Alibaba Cloud accounts and cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: A custom tag under the current Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software tag. You can obtain the value from the following operations:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~ListProhibitedTags~~">ListProhibitedTags</a>: Lists prohibited software tags.</description></item>
            /// <item><description><a href="~~CreateProhibitedTag~~">CreateProhibitedTag</a>: Creates a custom prohibited software tag.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tag-7b2c9e4a1d8f****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
