// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSystemParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CCDF65E-6050-412D-AD68-FA3D9196836C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned information about system parameters. It is an array that consists of SystemParam data.</para>
        /// </summary>
        [NameInMap("SystemParams")]
        [Validation(Required=false)]
        public DescribeSystemParametersResponseBodySystemParams SystemParams { get; set; }
        public class DescribeSystemParametersResponseBodySystemParams : TeaModel {
            [NameInMap("SystemParamItem")]
            [Validation(Required=false)]
            public List<DescribeSystemParametersResponseBodySystemParamsSystemParamItem> SystemParamItem { get; set; }
            public class DescribeSystemParametersResponseBodySystemParamsSystemParamItem : TeaModel {
                /// <summary>
                /// <para>Examples</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// <para>The description of a parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Client IP Address</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CaClientIp</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The type of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

            }

        }

    }

}
