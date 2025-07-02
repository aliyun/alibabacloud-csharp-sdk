// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListTerminalsRequest : TeaModel {
        [NameInMap("InManage")]
        [Validation(Required=false)]
        public bool? InManage { get; set; }

        [NameInMap("MainBizType")]
        [Validation(Required=false)]
        public string MainBizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdEdsXbwG2ZlbWCzN4wTTg6wQvfp7u1BJl4bxCAby41POSaYAlCvfULQpkAnb0ff****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PasswordFreeLoginUser")]
        [Validation(Required=false)]
        public string PasswordFreeLoginUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DemoDevice</para>
        /// </summary>
        [NameInMap("SearchKeyword")]
        [Validation(Required=false)]
        public string SearchKeyword { get; set; }

        [NameInMap("SerialNumbers")]
        [Validation(Required=false)]
        public List<string> SerialNumbers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tg-default</para>
        /// </summary>
        [NameInMap("TerminalGroupId")]
        [Validation(Required=false)]
        public string TerminalGroupId { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

        [NameInMap("WithBindUser")]
        [Validation(Required=false)]
        public bool? WithBindUser { get; set; }

    }

}
