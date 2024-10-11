// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class BlindTransferRequest : TeaModel {
        [NameInMap("CallPriority")]
        [Validation(Required=false)]
        public int? CallPriority { get; set; }

        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACC-YUNBS-1.0.10-****</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-6538214103685****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("QueuingOverflowThreshold")]
        [Validation(Required=false)]
        public long? QueuingOverflowThreshold { get; set; }

        [NameInMap("QueuingTimeoutSeconds")]
        [Validation(Required=false)]
        public long? QueuingTimeoutSeconds { get; set; }

        [NameInMap("RoutingType")]
        [Validation(Required=false)]
        public string RoutingType { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        [NameInMap("StrategyParams")]
        [Validation(Required=false)]
        public string StrategyParams { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("Transferee")]
        [Validation(Required=false)]
        public string Transferee { get; set; }

        [NameInMap("TransfereeType")]
        [Validation(Required=false)]
        public string TransfereeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>08314325****</para>
        /// </summary>
        [NameInMap("Transferor")]
        [Validation(Required=false)]
        public string Transferor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
