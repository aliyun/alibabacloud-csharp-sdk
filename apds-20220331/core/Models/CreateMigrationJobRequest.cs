// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class CreateMigrationJobRequest : TeaModel {
        [NameInMap("migrationJobList")]
        [Validation(Required=false)]
        public List<CreateMigrationJobRequestMigrationJobList> MigrationJobList { get; set; }
        public class CreateMigrationJobRequestMigrationJobList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            [NameInMap("destinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            [NameInMap("destinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            [NameInMap("jobGmtCreate")]
            [Validation(Required=false)]
            public string JobGmtCreate { get; set; }

            [NameInMap("jobGmtModified")]
            [Validation(Required=false)]
            public string JobGmtModified { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("originalPercent")]
            [Validation(Required=false)]
            public string OriginalPercent { get; set; }

            [NameInMap("originalProgress")]
            [Validation(Required=false)]
            public string OriginalProgress { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("originalStatus")]
            [Validation(Required=false)]
            public string OriginalStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("outSideId")]
            [Validation(Required=false)]
            public string OutSideId { get; set; }

            [NameInMap("properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("sourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
