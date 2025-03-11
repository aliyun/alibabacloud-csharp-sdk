// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates information about parameters.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeDrdsParamsResponseBodyList> List { get; set; }
        public class DescribeDrdsParamsResponseBodyList : TeaModel {
            /// <summary>
            /// <para>Indicates the name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_test</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>Indicates whether a restart is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedRestart")]
            [Validation(Required=false)]
            public bool? NeedRestart { get; set; }

            /// <summary>
            /// <para>Indicates the default value of a parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ParamDefaultValue")]
            [Validation(Required=false)]
            public string ParamDefaultValue { get; set; }

            /// <summary>
            /// <para>Indicates the description of the parameter.</para>
            /// </summary>
            [NameInMap("ParamDesc")]
            [Validation(Required=false)]
            public string ParamDesc { get; set; }

            /// <summary>
            /// <para>Indicates the name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLOW_SQL_TIME</para>
            /// </summary>
            [NameInMap("ParamEnglishName")]
            [Validation(Required=false)]
            public string ParamEnglishName { get; set; }

            /// <summary>
            /// <para>Indicates the parameter level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("ParamLevel")]
            [Validation(Required=false)]
            public string ParamLevel { get; set; }

            /// <summary>
            /// <para>Indicates the name of the parameter.</para>
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            /// <summary>
            /// <para>Indicates the value range of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[1000-900000]</para>
            /// </summary>
            [NameInMap("ParamRanges")]
            [Validation(Required=false)]
            public string ParamRanges { get; set; }

            /// <summary>
            /// <para>Indicates the type of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONFIG</para>
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// <para>Indicates the value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            /// <summary>
            /// <para>Indicates the name of the variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slowSqlTime</para>
            /// </summary>
            [NameInMap("ParamVariableName")]
            [Validation(Required=false)]
            public string ParamVariableName { get; set; }

        }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F7F8080-9132-4279-85D0-B7E5C4305162</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
