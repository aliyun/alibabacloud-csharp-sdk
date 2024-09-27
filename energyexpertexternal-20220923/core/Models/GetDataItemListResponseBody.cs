// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDataItemListResponseBody : TeaModel {
        /// <summary>
        /// <para>Response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDataItemListResponseBodyData> Data { get; set; }
        public class GetDataItemListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The identifier of the data item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_api_code</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The name of the data item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name_bbb</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Data filling method, 1: monthly value 2: annual value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The data item unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kg</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

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
