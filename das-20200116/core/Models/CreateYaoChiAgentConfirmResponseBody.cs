// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateYaoChiAgentConfirmResponseBody : TeaModel {
        /// <summary>
        /// <para>The confirmation decision submitted in this request, which is the same as the Approved request parameter. A value of true indicates that the execution is approved, and false indicates that the execution is rejected. This does not indicate whether the tool operation is executed successfully.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Approved")]
        [Validation(Required=false)]
        public bool? Approved { get; set; }

        /// <summary>
        /// <para>The identifier of the operation for which the confirmation is submitted, which is the same as the ConfirmationId request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-42d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("ConfirmationId")]
        [Validation(Required=false)]
        public string ConfirmationId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B23456</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status string. The example value success refers to the outer success status of the downstream confirmation callback response and is provided only for format demonstration. It does not mean that the Status field of the current operation actually returns this value. In the current version, this field may be empty or not returned. Do not rely on this field to determine whether the execution is approved or whether the tool is executed successfully.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether custom tool parameters are received. A value of true indicates that non-null parameters are provided, and false indicates that no parameters are provided. This does not indicate that the parameters are applied or that the tool is executed successfully. In the current version, omit the ToolArgs request parameter, and this field normally returns false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ToolArgsReceived")]
        [Validation(Required=false)]
        public bool? ToolArgsReceived { get; set; }

    }

}
