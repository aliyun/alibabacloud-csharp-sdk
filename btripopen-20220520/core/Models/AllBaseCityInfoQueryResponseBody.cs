// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AllBaseCityInfoQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public AllBaseCityInfoQueryResponseBodyModule Module { get; set; }
        public class AllBaseCityInfoQueryResponseBodyModule : TeaModel {
            [NameInMap("all_city_base_info_list")]
            [Validation(Required=false)]
            public List<AllBaseCityInfoQueryResponseBodyModuleAllCityBaseInfoList> AllCityBaseInfoList { get; set; }
            public class AllBaseCityInfoQueryResponseBodyModuleAllCityBaseInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>330122</para>
                /// </summary>
                [NameInMap("adcode")]
                [Validation(Required=false)]
                public string Adcode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0571</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("city_level")]
                [Validation(Required=false)]
                public string CityLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>桐庐</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>中国，浙江省，杭州市，桐庐</para>
                /// </summary>
                [NameInMap("cn_name_tree")]
                [Validation(Required=false)]
                public string CnNameTree { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("other_name_list")]
                [Validation(Required=false)]
                public List<string> OtherNameList { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
