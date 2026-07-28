// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class DBVersionDetail : TeaModel {
        /// <summary>
        /// <para>The specifications supported by the version.</para>
        /// </summary>
        [NameInMap("specs")]
        [Validation(Required=false)]
        public List<DBVersionDetailSpecs> Specs { get; set; }
        public class DBVersionDetailSpecs : TeaModel {
            /// <summary>
            /// <para>The component specifications.</para>
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
                /// <para>The maximum number of replicas for the component.</para>
                /// </summary>
                [NameInMap("maxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>The minimum number of replicas for the component.</para>
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
                /// <para>The available specifications for the component.</para>
                /// </summary>
                [NameInMap("specs")]
                [Validation(Required=false)]
                public List<string> Specs { get; set; }

                /// <summary>
                /// <para>The step size for scaling the number of replicas.</para>
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
            /// <para>Indicates whether the high availability (HA) edition is supported.</para>
            /// </summary>
            [NameInMap("isHA")]
            [Validation(Required=false)]
            public bool? IsHA { get; set; }

            /// <summary>
            /// <para>Indicates whether the Standalone edition is supported.</para>
            /// </summary>
            [NameInMap("isStandalone")]
            [Validation(Required=false)]
            public bool? IsStandalone { get; set; }

            /// <summary>
            /// <para>Indicates whether the Standalone Pro edition is supported.</para>
            /// </summary>
            [NameInMap("isStandalonePro")]
            [Validation(Required=false)]
            public bool? IsStandalonePro { get; set; }

            /// <summary>
            /// <para>The zone mode of the specification.</para>
            /// </summary>
            [NameInMap("zoneMode")]
            [Validation(Required=false)]
            public string ZoneMode { get; set; }

        }

        /// <summary>
        /// <para>The status of the version.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
