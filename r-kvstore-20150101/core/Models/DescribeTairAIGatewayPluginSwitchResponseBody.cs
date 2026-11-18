// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairAIGatewayPluginSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID, which is globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tg-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeTairAIGatewayPluginSwitchResponseBodyParameters Parameters { get; set; }
        public class DescribeTairAIGatewayPluginSwitchResponseBodyParameters : TeaModel {
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeTairAIGatewayPluginSwitchResponseBodyParametersParameters> Parameters { get; set; }
            public class DescribeTairAIGatewayPluginSwitchResponseBodyParametersParameters : TeaModel {
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBC1E3D6-7C88-4DF5-9A3D-0DB1E6D9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries for the plug-in switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
