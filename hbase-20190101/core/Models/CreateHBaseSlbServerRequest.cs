// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateHBaseSlbServerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx-xxxxx-xxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-t4naqsay5gn****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thrift</para>
        /// </summary>
        [NameInMap("SlbServer")]
        [Validation(Required=false)]
        public string SlbServer { get; set; }

    }

}
