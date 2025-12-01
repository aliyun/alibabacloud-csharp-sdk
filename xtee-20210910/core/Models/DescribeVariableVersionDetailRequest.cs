// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableVersionDetailRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Associated variable name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dHSi2zf5bb8</para>
        /// </summary>
        [NameInMap("objectCode")]
        [Validation(Required=false)]
        public string ObjectCode { get; set; }

        /// <summary>
        /// <para>Associated variable ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3434</para>
        /// </summary>
        [NameInMap("objectId")]
        [Validation(Required=false)]
        public long? ObjectId { get; set; }

        /// <summary>
        /// <para>Region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VELOCITY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
