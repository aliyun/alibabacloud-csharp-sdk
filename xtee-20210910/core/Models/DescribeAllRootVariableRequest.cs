// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAllRootVariableRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Request source IP. No need to fill in, the system will automatically obtain it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61.169.104.202</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Device variable list</para>
        /// 
        /// <b>Example:</b>
        /// <para>[180]</para>
        /// </summary>
        [NameInMap("deviceVariableIds")]
        [Validation(Required=false)]
        public string DeviceVariableIds { get; set; }

        /// <summary>
        /// <para>Event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_arqbuy7206</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>Custom variable list</para>
        /// 
        /// <b>Example:</b>
        /// <para>[6780]</para>
        /// </summary>
        [NameInMap("expressionVariableIds")]
        [Validation(Required=false)]
        public string ExpressionVariableIds { get; set; }

        /// <summary>
        /// <para>Variable ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2557</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Event field list</para>
        /// 
        /// <b>Example:</b>
        /// <para>[106780]</para>
        /// </summary>
        [NameInMap("nativeVariableIds")]
        [Validation(Required=false)]
        public string NativeVariableIds { get; set; }

        /// <summary>
        /// <para>Custom query variable</para>
        /// 
        /// <b>Example:</b>
        /// <para>[2678]</para>
        /// </summary>
        [NameInMap("queryVariableIds")]
        [Validation(Required=false)]
        public string QueryVariableIds { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Custom cumulative variable</para>
        /// 
        /// <b>Example:</b>
        /// <para>[780]</para>
        /// </summary>
        [NameInMap("velocityVariableIds")]
        [Validation(Required=false)]
        public string VelocityVariableIds { get; set; }

    }

}
