// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data. The category node information, in the format of a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;categoryId\&quot;:\&quot;43c2671b-8939-4223-<b><b>-6bd187905cc8\&quot;,\&quot;childCategoryList\&quot;:[{\&quot;categoryId\&quot;:\&quot;120816ad-4392-4edf-</b></b>-6d053d5cfa5a\&quot;,\&quot;childCategoryList\&quot;:[],\&quot;deleted\&quot;:0,\&quot;editor\&quot;:\&quot;283277706217028904\&quot;,\&quot;editorName\&quot;:\&quot;283277706217028904\&quot;,\&quot;instanceId\&quot;:\&quot;cccV2-kmz\&quot;,\&quot;itemCount\&quot;:0,\&quot;level\&quot;:2,\&quot;name\&quot;:\&quot;客户反馈\&quot;,\&quot;parentCategoryId\&quot;:\&quot;43c2671b-8939-<b><b>-86d0-6bd187905cc8\&quot;,\&quot;type\&quot;:\&quot;Ticket\&quot;}],\&quot;deleted\&quot;:0,\&quot;editor\&quot;:\&quot;283277706217028904\&quot;,\&quot;editorName\&quot;:\&quot;283277706217028904\&quot;,\&quot;instanceId\&quot;:\&quot;cccV2-kmz\&quot;,\&quot;itemCount\&quot;:10,\&quot;level\&quot;:1,\&quot;name\&quot;:\&quot;测试一01类目\&quot;,\&quot;type\&quot;:\&quot;Ticket\&quot;},{\&quot;categoryId\&quot;:\&quot;4948fcd0-2972-</b></b>-81c6-1a00927e1802\&quot;,\&quot;childCategoryList\&quot;:[],\&quot;deleted\&quot;:0,\&quot;editor\&quot;:\&quot;283277706217028904\&quot;,\&quot;editorName\&quot;:\&quot;283277706217028904\&quot;,\&quot;instanceId\&quot;:\&quot;cccV2-kmz\&quot;,\&quot;itemCount\&quot;:0,\&quot;level\&quot;:1,\&quot;name\&quot;:\&quot;生产环境验证\&quot;,\&quot;type\&quot;:\&quot;Ticket\&quot;},{\&quot;categoryId\&quot;:\&quot;c426bd7f-9661-47c3-****-2508f1a32f66\&quot;,\&quot;childCategoryList\&quot;:[],\&quot;deleted\&quot;:0,\&quot;editor\&quot;:\&quot;269801834095770945\&quot;,\&quot;editorName\&quot;:\&quot;269801834095770945\&quot;,\&quot;instanceId\&quot;:\&quot;cccV2-kmz\&quot;,\&quot;itemCount\&quot;:4,\&quot;level\&quot;:1,\&quot;name\&quot;:\&quot;测试环境测试\&quot;,\&quot;type\&quot;:\&quot;Ticket\&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of incorrect parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE803553-8AA9-4B9D-9E4E-A82BC69EDCEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
