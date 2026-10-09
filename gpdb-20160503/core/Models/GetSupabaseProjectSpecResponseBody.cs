// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseProjectSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Supabase project specifications.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetSupabaseProjectSpecResponseBodyItems> Items { get; set; }
        public class GetSupabaseProjectSpecResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the specification is free.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Free")]
            [Validation(Required=false)]
            public bool? Free { get; set; }

            /// <summary>
            /// <para>The specification code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2C4G</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>Indicates whether the specification is visible.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Visible")]
            [Validation(Required=false)]
            public bool? Visible { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of zone IDs that support creating Supabase projects.</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
