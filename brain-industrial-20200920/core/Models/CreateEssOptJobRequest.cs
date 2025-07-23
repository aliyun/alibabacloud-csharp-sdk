// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreateEssOptJobRequest : TeaModel {
        [NameInMap("BusinessKey")]
        [Validation(Required=false)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("ElecPrice")]
        [Validation(Required=false)]
        public List<CreateEssOptJobRequestElecPrice> ElecPrice { get; set; }
        public class CreateEssOptJobRequestElecPrice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>00:00:15</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FIFTEEN_MIN</para>
        /// </summary>
        [NameInMap("Freq")]
        [Validation(Required=false)]
        public string Freq { get; set; }

        [NameInMap("GenPrice")]
        [Validation(Required=false)]
        public List<CreateEssOptJobRequestGenPrice> GenPrice { get; set; }
        public class CreateEssOptJobRequestGenPrice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>00:00:15</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

        }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public CreateEssOptJobRequestLocation Location { get; set; }
        public class CreateEssOptJobRequestLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10.123</para>
            /// </summary>
            [NameInMap("Altitude")]
            [Validation(Required=false)]
            public double? Altitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40.027</para>
            /// </summary>
            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public double? Latitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120.042</para>
            /// </summary>
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public double? Longitude { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-12</para>
        /// </summary>
        [NameInMap("RunDate")]
        [Validation(Required=false)]
        public string RunDate { get; set; }

        [NameInMap("SystemData")]
        [Validation(Required=false)]
        public List<CreateEssOptJobRequestSystemData> SystemData { get; set; }
        public class CreateEssOptJobRequestSystemData : TeaModel {
            [NameInMap("HistoryData")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> HistoryData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SystemId")]
            [Validation(Required=false)]
            public string SystemId { get; set; }

            [NameInMap("SystemParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> SystemParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("SystemType")]
            [Validation(Required=false)]
            public string SystemType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LOAD_ESS_SOLAR</para>
        /// </summary>
        [NameInMap("TopoType")]
        [Validation(Required=false)]
        public string TopoType { get; set; }

    }

}
