// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKeystoresRequest : TeaModel {
        /// <summary>
        /// <para>Removes the keystore configuration.</para>
        /// </summary>
        [NameInMap("remove")]
        [Validation(Required=false)]
        public List<string> Remove { get; set; }

        /// <summary>
        /// <para>Adds or updates the keystore.</para>
        /// </summary>
        [NameInMap("update")]
        [Validation(Required=false)]
        public Dictionary<string, string> Update { get; set; }

        /// <summary>
        /// <para>Specifies whether to force the update. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Forced.</description></item>
        /// <item><description>false: Not forced.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public string Force { get; set; }

    }

}
