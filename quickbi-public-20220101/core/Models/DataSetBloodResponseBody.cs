// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataSetBloodResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Array of works.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DataSetBloodResponseBodyResult> Result { get; set; }
        public class DataSetBloodResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Work ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccd3428c-<b><b>-</b></b>-a608-26bae29dffee</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <para>Work types: - REPORT: </para>
            /// <list type="bullet">
            /// <item><description>REPORT: Workbooks</description></item>
            /// <item><description>dashboardOfflineQuery: Downloads</description></item>
            /// <item><description>DASHBOARD: Dashboard</description></item>
            /// <item><description>ANALYSIS: Ad Hoc Analysis</description></item>
            /// <item><description>SCREEN: Visualization Screen</description></item>
            /// <item><description>PAGE: Old dashboard</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAGE</para>
            /// </summary>
            [NameInMap("WorksType")]
            [Validation(Required=false)]
            public string WorksType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Request succeeded</description></item>
        /// <item><description>false: Request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
