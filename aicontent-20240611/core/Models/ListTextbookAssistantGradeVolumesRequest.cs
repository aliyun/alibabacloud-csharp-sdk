// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantGradeVolumesRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code for API calls. You can obtain it by calling the API operation that retrieves the authorization code for the English textbook AI teacher feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_197bf5bb81889cc79eb51ae9b8c0cea3</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>Scenarios. Valid values: SYNC: synchronization practice, EXPAND: extended practice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

    }

}
