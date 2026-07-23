// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobFeatureReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://********</para>
        /// </summary>
        [NameInMap("DataPath")]
        [Validation(Required=false)]
        public string DataPath { get; set; }

        /// <summary>
        /// <para>The OSS path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://********</para>
        /// </summary>
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <para>The feature comparison reports.</para>
        /// </summary>
        [NameInMap("ReportsOfFeatureDiff")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobFeatureReportsResponseBodyReportsOfFeatureDiff> ReportsOfFeatureDiff { get; set; }
        public class ListFeatureConsistencyCheckJobFeatureReportsResponseBodyReportsOfFeatureDiff : TeaModel {
            /// <summary>
            /// <para>The feature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gender</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9010</para>
            /// </summary>
            [NameInMap("LogItemId")]
            [Validation(Required=false)]
            public string LogItemId { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
            /// </summary>
            [NameInMap("LogRequestId")]
            [Validation(Required=false)]
            public string LogRequestId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1010</para>
            /// </summary>
            [NameInMap("LogUserId")]
            [Validation(Required=false)]
            public string LogUserId { get; set; }

            /// <summary>
            /// <para>The offline value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>male</para>
            /// </summary>
            [NameInMap("OfflineValue")]
            [Validation(Required=false)]
            public string OfflineValue { get; set; }

            /// <summary>
            /// <para>The online value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>male</para>
            /// </summary>
            [NameInMap("OnlineValue")]
            [Validation(Required=false)]
            public string OnlineValue { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBD41FBF-E75C-551A-92FA-CAD654AA006F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
