// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAllRootVariableRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. The system automatically obtains the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61.169.104.202</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The list of device variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[180]</para>
        /// </summary>
        [NameInMap("deviceVariableIds")]
        [Validation(Required=false)]
        public string DeviceVariableIds { get; set; }

        /// <summary>
        /// <para>The event code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_arqbuy7206</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>The list of custom variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[6780]</para>
        /// </summary>
        [NameInMap("expressionVariableIds")]
        [Validation(Required=false)]
        public string ExpressionVariableIds { get; set; }

        /// <summary>
        /// <para>The variable ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2557</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The list of event fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[106780]</para>
        /// </summary>
        [NameInMap("nativeVariableIds")]
        [Validation(Required=false)]
        public string NativeVariableIds { get; set; }

        /// <summary>
        /// <para>The custom query variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[2678]</para>
        /// </summary>
        [NameInMap("queryVariableIds")]
        [Validation(Required=false)]
        public string QueryVariableIds { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The custom cumulative variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[780]</para>
        /// </summary>
        [NameInMap("velocityVariableIds")]
        [Validation(Required=false)]
        public string VelocityVariableIds { get; set; }

    }

}
