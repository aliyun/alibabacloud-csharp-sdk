// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class OperateAppRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public int? AppId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud phone instances.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The type of the operation.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>stop: closes the app.</description></item>
        /// <item><description>restart: reopens the app.</description></item>
        /// <item><description>start: open the app.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

    }

}
