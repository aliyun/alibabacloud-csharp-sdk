// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APP_PBxxx</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123</para>
        /// </summary>
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-xxafafaf</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>o-YDJKIxxx</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</para>
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hexxyy</para>
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hexabc1234</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public string SystemType { get; set; }

    }

}
