// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyPersonasSexStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>013DA6E1-3F37-5579-B979-2F12B7E92450</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyPersonasSexStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyPersonasSexStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Number of users under 14 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Age0To14Cnt")]
            [Validation(Required=false)]
            public long? Age0To14Cnt { get; set; }

            /// <summary>
            /// <para>Proportion of users under 14 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Age0To14Rate")]
            [Validation(Required=false)]
            public string Age0To14Rate { get; set; }

            /// <summary>
            /// <para>Number of users between 14 and 18 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Age14To18Cnt")]
            [Validation(Required=false)]
            public long? Age14To18Cnt { get; set; }

            /// <summary>
            /// <para>Proportion of users between 14 and 18 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Age14To18Rate")]
            [Validation(Required=false)]
            public string Age14To18Rate { get; set; }

            /// <summary>
            /// <para>Number of authenticated users between 18 and 35 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Age18To35Cnt")]
            [Validation(Required=false)]
            public long? Age18To35Cnt { get; set; }

            /// <summary>
            /// <para>Proportion of authenticated users between 18 and 35 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64.29</para>
            /// </summary>
            [NameInMap("Age18To35Rate")]
            [Validation(Required=false)]
            public string Age18To35Rate { get; set; }

            /// <summary>
            /// <para>Number of authenticated users between 35 and 50 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Age35To50Cnt")]
            [Validation(Required=false)]
            public long? Age35To50Cnt { get; set; }

            /// <summary>
            /// <para>Proportion of users between 35 and 50 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35.71</para>
            /// </summary>
            [NameInMap("Age35To50Rate")]
            [Validation(Required=false)]
            public string Age35To50Rate { get; set; }

            /// <summary>
            /// <para>Number of authenticated users over 50 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Age50To999Cnt")]
            [Validation(Required=false)]
            public long? Age50To999Cnt { get; set; }

            /// <summary>
            /// <para>Proportion of authenticated users over 50 years old.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Age50To999Rate")]
            [Validation(Required=false)]
            public string Age50To999Rate { get; set; }

            /// <summary>
            /// <para>Total number of authenticated users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("AllUserCnt")]
            [Validation(Required=false)]
            public long? AllUserCnt { get; set; }

            /// <summary>
            /// <para>Number of female users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("FemaleCnt")]
            [Validation(Required=false)]
            public long? FemaleCnt { get; set; }

            /// <summary>
            /// <para>Proportion of female authenticated users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28.57</para>
            /// </summary>
            [NameInMap("FemaleRate")]
            [Validation(Required=false)]
            public string FemaleRate { get; set; }

            /// <summary>
            /// <para>Number of male users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaleCnt")]
            [Validation(Required=false)]
            public long? MaleCnt { get; set; }

            /// <summary>
            /// <para>Proportion of male users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>71.43</para>
            /// </summary>
            [NameInMap("MaleRate")]
            [Validation(Required=false)]
            public string MaleRate { get; set; }

        }

    }

}
