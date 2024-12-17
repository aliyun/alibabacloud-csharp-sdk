// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupSupportParamResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB73740C-23E2-4392-9DA4-2660C74C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The parameters.</para>
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupSupportParamResponseBodyResourceList> ResourceList { get; set; }
        public class DescribeParameterGroupSupportParamResponseBodyResourceList : TeaModel {
            /// <summary>
            /// <para>The service category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rt_threshold_ms</para>
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

        }

    }

}
