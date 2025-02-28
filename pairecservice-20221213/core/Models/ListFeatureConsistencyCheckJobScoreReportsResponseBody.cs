// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobScoreReportsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http://*******</para>
        /// </summary>
        [NameInMap("DataPath")]
        [Validation(Required=false)]
        public string DataPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://********</para>
        /// </summary>
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("ReportsOfScoreDiff")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobScoreReportsResponseBodyReportsOfScoreDiff> ReportsOfScoreDiff { get; set; }
        public class ListFeatureConsistencyCheckJobScoreReportsResponseBodyReportsOfScoreDiff : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("LogItemId")]
            [Validation(Required=false)]
            public string LogItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>323</para>
            /// </summary>
            [NameInMap("LogRequestId")]
            [Validation(Required=false)]
            public string LogRequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LogUserId")]
            [Validation(Required=false)]
            public string LogUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.00000234</para>
            /// </summary>
            [NameInMap("ScoreDiff")]
            [Validation(Required=false)]
            public string ScoreDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ScoreDiffDetail")]
            [Validation(Required=false)]
            public string ScoreDiffDetail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F0AB6527-093F-5C44-B3BD-42C8C210C619</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
