// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafStartStepsRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Whether the server is an Alibaba Cloud server</para>
        /// <para>true or false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("aliyunServer")]
        [Validation(Required=false)]
        public bool? AliyunServer { get; set; }

        /// <summary>
        /// <para>Used to receive a collection of strings from the frontend that POP cannot accept</para>
        /// <para>Device type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ios</para>
        /// </summary>
        [NameInMap("deviceTypesStr")]
        [Validation(Required=false)]
        public string DeviceTypesStr { get; set; }

        /// <summary>
        /// <para>Event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ahqido8038</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>Language, parameters can be passed</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese (default)</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

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
        /// <para>Server region</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("serverRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

    }

}
