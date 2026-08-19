// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetDeviceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The device label details.</para>
        /// </summary>
        [NameInMap("DeviceGroup")]
        [Validation(Required=false)]
        public GetDeviceGroupResponseBodyDeviceGroup DeviceGroup { get; set; }
        public class GetDeviceGroupResponseBodyDeviceGroup : TeaModel {
            /// <summary>
            /// <para>The device label description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test device group description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The device label ID.</para>
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
            /// <para>The dynamic device group rule operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("DynamicOperator")]
            [Validation(Required=false)]
            [Obsolete]
            public string DynamicOperator { get; set; }

            /// <summary>
            /// <para>The matching rule of the dynamic device label.</para>
            /// </summary>
            [NameInMap("DynamicRule")]
            [Validation(Required=false)]
            public Rule DynamicRule { get; set; }

            /// <summary>
            /// <para>The device label type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>static</b>: Static device label. Members consist of manually added terminal devices.</description></item>
            /// <item><description><b>dynamic</b>: Dynamic device label.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>Indicates whether the device label is a system built-in device label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: System built-in device label.</description></item>
            /// <item><description><b>false</b>: User-defined device label.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The collection of terminal device IDs associated with the device label.</para>
            /// </summary>
            [NameInMap("MatchDevTags")]
            [Validation(Required=false)]
            public List<string> MatchDevTags { get; set; }

            /// <summary>
            /// <para>The device label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_a1b2bfd0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
