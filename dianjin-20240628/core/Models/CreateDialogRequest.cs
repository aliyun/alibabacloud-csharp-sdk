// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateDialogRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taobao</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("enableLibrary")]
        [Validation(Required=false)]
        public bool? EnableLibrary { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("metaData")]
        [Validation(Required=false)]
        public Dictionary<string, object> MetaData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live_broadcast_qa</para>
        /// </summary>
        [NameInMap("playCode")]
        [Validation(Required=false)]
        public string PlayCode { get; set; }

        [NameInMap("qaLibraryList")]
        [Validation(Required=false)]
        public List<string> QaLibraryList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ebf83826-dc1c-46f8-9759-0fb6da4c8xxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("selfDirected")]
        [Validation(Required=false)]
        public bool? SelfDirected { get; set; }

    }

}
