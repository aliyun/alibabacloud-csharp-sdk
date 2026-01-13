// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class CreateCustomerModuleOutputInfoRequest : TeaModel {
        /// <summary>
        /// <para>Customer model ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomerModuleId")]
        [Validation(Required=false)]
        public int? CustomerModuleId { get; set; }

        /// <summary>
        /// <para>Number of decimal places to retain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FinalScoreFormat")]
        [Validation(Required=false)]
        public string FinalScoreFormat { get; set; }

        /// <summary>
        /// <para>Score processing logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>score</para>
        /// </summary>
        [NameInMap("ProcessExpression")]
        [Validation(Required=false)]
        public string ProcessExpression { get; set; }

        /// <summary>
        /// <para>Test file URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer/xxxxxxxxx/xxxxxxxx.pmml</para>
        /// </summary>
        [NameInMap("TestFileUrl")]
        [Validation(Required=false)]
        public string TestFileUrl { get; set; }

    }

}
