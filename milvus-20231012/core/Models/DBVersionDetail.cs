// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class DBVersionDetail : TeaModel {
        /// <summary>
        /// <para>The list of specifications supported by the database version.</para>
        /// </summary>
        [NameInMap("specs")]
        [Validation(Required=false)]
        public List<DBVersionDetailSpecs> Specs { get; set; }
        public class DBVersionDetailSpecs : TeaModel {
            /// <summary>
            /// <para>The list of component specification configurations.</para>
            /// </summary>
            [NameInMap("componentSpecs")]
            [Validation(Required=false)]
            public List<DBVersionDetailSpecsComponentSpecs> ComponentSpecs { get; set; }
            public class DBVersionDetailSpecsComponentSpecs : TeaModel {
                /// <summary>
                /// <para>The default number of replicas for the component.</para>
                /// </summary>
                [NameInMap("defaultReplicas")]
                [Validation(Required=false)]
                public int? DefaultReplicas { get; set; }

                /// <summary>
                /// <para>The maximum number of replicas allowed for the component.</para>
                /// </summary>
                [NameInMap("maxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>The minimum number of replicas allowed for the component.</para>
                /// </summary>
                [NameInMap("minReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// <para>The name of the component.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of specifications supported by the component.</para>
                /// </summary>
                [NameInMap("specs")]
                [Validation(Required=false)]
                public List<string> Specs { get; set; }

                /// <summary>
                /// <para>The step size for adjusting the number of replicas for the component.</para>
                /// </summary>
                [NameInMap("step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

                /// <summary>
                /// <para>The type of the component.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether high-availability deployment is supported.</para>
            /// </summary>
            [NameInMap("isHA")]
            [Validation(Required=false)]
            public bool? IsHA { get; set; }

            /// <summary>
            /// <para>Specifies whether standalone deployment is supported.</para>
            /// </summary>
            [NameInMap("isStandalone")]
            [Validation(Required=false)]
            public bool? IsStandalone { get; set; }

            /// <summary>
            /// <para>Specifies whether Standalone Pro deployment is supported.</para>
            /// </summary>
            [NameInMap("isStandalonePro")]
            [Validation(Required=false)]
            public bool? IsStandalonePro { get; set; }

            /// <summary>
            /// <para>The zone deployment mode supported by the specification.</para>
            /// </summary>
            [NameInMap("zoneMode")]
            [Validation(Required=false)]
            public string ZoneMode { get; set; }

        }

        /// <summary>
        /// <para>The status of the database version.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The database version.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
