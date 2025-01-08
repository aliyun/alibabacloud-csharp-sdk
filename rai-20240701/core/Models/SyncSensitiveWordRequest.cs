// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class SyncSensitiveWordRequest : TeaModel {
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public SyncSensitiveWordRequestBodyData BodyData { get; set; }
        public class SyncSensitiveWordRequestBodyData : TeaModel {
            [NameInMap("SensitiveWordList")]
            [Validation(Required=false)]
            public List<SyncSensitiveWordRequestBodyDataSensitiveWordList> SensitiveWordList { get; set; }
            public class SyncSensitiveWordRequestBodyDataSensitiveWordList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>341806</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Commit")]
        [Validation(Required=false)]
        public bool? Commit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
