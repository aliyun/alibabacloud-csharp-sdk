// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetAreaElecConstituteResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned for the request. A value of Success indicates that the request was successful. Other values indicate that the request failed. You can troubleshoot the error by viewing the error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAreaElecConstituteResponseBodyData Data { get; set; }
        public class GetAreaElecConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Photoelectric power consumption and carbon emission data of each enterprise.</para>
            /// </summary>
            [NameInMap("light")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Light { get; set; }

            /// <summary>
            /// <para>Data on nuclear power consumption and carbon emissions at each enterprise.</para>
            /// </summary>
            [NameInMap("nuclear")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Nuclear { get; set; }

            /// <summary>
            /// <para>Data on renewable electricity consumption and carbon emissions at each enterprise.</para>
            /// </summary>
            [NameInMap("renewing")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Renewing { get; set; }

            /// <summary>
            /// <para>Data on mains electricity consumption and carbon emission of each enterprise.</para>
            /// </summary>
            [NameInMap("urban")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Urban { get; set; }

            /// <summary>
            /// <para>Hydropower consumption and carbon emission data of each enterprise.</para>
            /// </summary>
            [NameInMap("water")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Water { get; set; }

            /// <summary>
            /// <para>Wind power consumption and carbon emission data of each enterprise.</para>
            /// </summary>
            [NameInMap("wind")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Wind { get; set; }

            /// <summary>
            /// <para>Data of zero electricity consumption and carbon emission of each enterprise.</para>
            /// </summary>
            [NameInMap("zero")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Zero { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
