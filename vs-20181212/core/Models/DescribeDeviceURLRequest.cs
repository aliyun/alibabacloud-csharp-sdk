// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDeviceURLRequest : TeaModel {
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public bool? Auth { get; set; }

        /// <summary>
        /// <para>Authentication validity period, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>Device ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****380-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Stream mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>play</para>
        /// </description></item>
        /// <item><description><para>push</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>push</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Stream protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>rtmp</para>
        /// </description></item>
        /// <item><description><para>flv</para>
        /// </description></item>
        /// <item><description><para>hls</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When Mode is set to push, only rtmp is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Stream name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live001</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
