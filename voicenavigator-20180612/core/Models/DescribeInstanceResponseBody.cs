// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ability type.<br>
        /// DEFAULT: full abilities.<br>
        /// VOICE_ONLY: only voice abilities, without dialog intervention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VOICE_ONLY</para>
        /// </summary>
        [NameInMap("AbilityType")]
        [Validation(Required=false)]
        public string AbilityType { get; set; }

        /// <summary>
        /// <para>The list of applicable operations.</para>
        /// </summary>
        [NameInMap("ApplicableOperations")]
        [Validation(Required=false)]
        public List<string> ApplicableOperations { get; set; }

        /// <summary>
        /// <para>The instance concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>导航测试实例描述信息</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd6fc91bc13445c2af7f2e3e31418520</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683216000000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The user who last updated the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2508711*******</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>导航测试实例</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NluServiceParamsJson")]
        [Validation(Required=false)]
        public string NluServiceParamsJson { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>790B5EA3-D251-1666-B1E0-4D1F4B33A592</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Published</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UnionInstanceId")]
        [Validation(Required=false)]
        public string UnionInstanceId { get; set; }

        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
