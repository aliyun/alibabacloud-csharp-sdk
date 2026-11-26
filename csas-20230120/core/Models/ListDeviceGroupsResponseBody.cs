// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDeviceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of device groups.</para>
        /// </summary>
        [NameInMap("DeviceGroups")]
        [Validation(Required=false)]
        public List<ListDeviceGroupsResponseBodyDeviceGroups> DeviceGroups { get; set; }
        public class ListDeviceGroupsResponseBodyDeviceGroups : TeaModel {
            /// <summary>
            /// <para>The description of the device group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the device group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>device-group-5191cf830a5e****</para>
            /// </summary>
            [NameInMap("DeviceGroupId")]
            [Validation(Required=false)]
            public string DeviceGroupId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The operator for the dynamic device group rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("DynamicOperator")]
            [Validation(Required=false)]
            [Obsolete]
            public string DynamicOperator { get; set; }

            /// <summary>
            /// <para>The matching rule for the dynamic device group.</para>
            /// </summary>
            [NameInMap("DynamicRule")]
            [Validation(Required=false)]
            public Rule DynamicRule { get; set; }

            /// <summary>
            /// <para>The type of the device group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>static</b>: A static device group. Its members are manually added terminal devices.</description></item>
            /// <item><description><b>dynamic</b>: A dynamic device group. Its members are automatically calculated based on matching rules when terminal devices report heartbeats.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>Specifies whether the device group is a built-in system device group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The device group is a built-in system device group.</description></item>
            /// <item><description><b>false</b>: The device group is a custom device group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The IDs of the terminal devices associated with the device group.</para>
            /// </summary>
            [NameInMap("MatchDevTags")]
            [Validation(Required=false)]
            public List<string> MatchDevTags { get; set; }

            /// <summary>
            /// <para>The name of the device group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD724DBC-CD76-5235-BF76-59C51B73296D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of device groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
