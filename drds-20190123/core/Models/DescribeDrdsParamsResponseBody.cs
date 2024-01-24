// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsParamsResponseBody : TeaModel {
        /// <summary>
        /// Indicates information about parameters.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeDrdsParamsResponseBodyList> List { get; set; }
        public class DescribeDrdsParamsResponseBodyList : TeaModel {
            /// <summary>
            /// Indicates the name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// Indicates whether a restart is required.
            /// </summary>
            [NameInMap("NeedRestart")]
            [Validation(Required=false)]
            public bool? NeedRestart { get; set; }

            /// <summary>
            /// Indicates the default value of a parameter.
            /// </summary>
            [NameInMap("ParamDefaultValue")]
            [Validation(Required=false)]
            public string ParamDefaultValue { get; set; }

            /// <summary>
            /// Indicates the description of the parameter.
            /// </summary>
            [NameInMap("ParamDesc")]
            [Validation(Required=false)]
            public string ParamDesc { get; set; }

            /// <summary>
            /// Indicates the name of the parameter.
            /// </summary>
            [NameInMap("ParamEnglishName")]
            [Validation(Required=false)]
            public string ParamEnglishName { get; set; }

            /// <summary>
            /// Indicates the parameter level.
            /// </summary>
            [NameInMap("ParamLevel")]
            [Validation(Required=false)]
            public string ParamLevel { get; set; }

            /// <summary>
            /// Indicates the name of the parameter.
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            /// <summary>
            /// Indicates the value range of the parameter.
            /// </summary>
            [NameInMap("ParamRanges")]
            [Validation(Required=false)]
            public string ParamRanges { get; set; }

            /// <summary>
            /// Indicates the type of the parameter.
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// Indicates the value of the parameter.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            /// <summary>
            /// Indicates the name of the variable.
            /// </summary>
            [NameInMap("ParamVariableName")]
            [Validation(Required=false)]
            public string ParamVariableName { get; set; }

        }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
