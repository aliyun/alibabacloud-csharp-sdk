// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UpdatePropertyRequest : TeaModel {
        /// <summary>
        /// <para>The business channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The ID of the property to update. You can call <a href="~~ListProperty~~">ListProperty</a> to query the property ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>390</para>
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// <para>The updated property name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testkey</para>
        /// </summary>
        [NameInMap("PropertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// <para>The list of all updated property values for the property.</para>
        /// <remarks>
        /// <para>Notice: The property values specified here overwrite the existing property values instead of appending to them.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PropertyValues")]
        [Validation(Required=false)]
        public List<UpdatePropertyRequestPropertyValues> PropertyValues { get; set; }
        public class UpdatePropertyRequestPropertyValues : TeaModel {
            /// <summary>
            /// <para>The updated property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue</para>
            /// </summary>
            [NameInMap("PropertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

            /// <summary>
            /// <para>The ID of the updated property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>978</para>
            /// </summary>
            [NameInMap("PropertyValueId")]
            [Validation(Required=false)]
            public long? PropertyValueId { get; set; }

        }

    }

}
