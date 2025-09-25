// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateVerifySettingResponseBody : TeaModel {
        /// <summary>
        /// <para>Verification scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户注册</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>Verification scenario identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserRegister</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6163397-15C5-419C-9ACC-B7C83E0B4C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Authentication solution name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPBasic</para>
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

        /// <summary>
        /// <para>Authentication steps</para>
        /// </summary>
        [NameInMap("StepList")]
        [Validation(Required=false)]
        public List<string> StepList { get; set; }

    }

}
