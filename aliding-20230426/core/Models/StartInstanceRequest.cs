// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APP_PBxxx</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18295</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("FormDataJson")]
        [Validation(Required=false)]
        public string FormDataJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FORM-EF6Yxxx</para>
        /// </summary>
        [NameInMap("FormUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TPROC--EF6Y4xxx</para>
        /// </summary>
        [NameInMap("ProcessCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("ProcessData")]
        [Validation(Required=false)]
        public string ProcessData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hexxyy</para>
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

    }

}
