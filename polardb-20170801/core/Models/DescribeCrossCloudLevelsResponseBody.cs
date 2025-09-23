// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudLevelsResponseBody : TeaModel {
        [NameInMap("CrossCloudLevelList")]
        [Validation(Required=false)]
        public List<DescribeCrossCloudLevelsResponseBodyCrossCloudLevelList> CrossCloudLevelList { get; set; }
        public class DescribeCrossCloudLevelsResponseBodyCrossCloudLevelList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polar.mysql.g4.medium.c</para>
            /// </summary>
            [NameInMap("LevelCode")]
            [Validation(Required=false)]
            public string LevelCode { get; set; }

            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
