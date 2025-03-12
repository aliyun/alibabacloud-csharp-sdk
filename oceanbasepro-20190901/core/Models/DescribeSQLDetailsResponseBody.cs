// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeSQLDetails</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=DescribeSQLDetails
        /// &amp;TenantId=t2mr3oae0****
        /// &amp;SQLId=8D6E84****0B8FB1823D199E2CA1****
        /// &amp;Common request parameters
        /// </c></pre>
        /// </summary>
        [NameInMap("SQLDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLDetailsResponseBodySQLDetails> SQLDetails { get; set; }
        public class DescribeSQLDetailsResponseBodySQLDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>{&quot;name&quot;:&quot;DescribeSQLDetails&quot;,&quot;product&quot;:&quot;OceanBasePro&quot;,&quot;version&quot;:&quot;2019-09-01&quot;,&quot;path&quot;:&quot;/&quot;,&quot;deprecated&quot;:0,&quot;method&quot;:&quot;POST|GET&quot;,&quot;protocol&quot;:&quot;HTTP|HTTPS&quot;,&quot;hidden&quot;:0,&quot;timeout&quot;:10000,&quot;parameter_type&quot;:&quot;Single&quot;,&quot;params&quot;:&quot;[{\&quot;name\&quot;:\&quot;Action\&quot;,\&quot;position\&quot;:\&quot;Query\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;DescribeSQLDetails\&quot;},{\&quot;name\&quot;:\&quot;TenantId\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;t2mr3oae0****\&quot;},{\&quot;name\&quot;:\&quot;SQLId\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;SQLID\&quot;,\&quot;description\&quot;:\&quot;SQLID。\&quot;,\&quot;example\&quot;:\&quot;8D6E84<b><b>0B8FB1823D199E2CA1</b></b>\&quot;}]&quot;,&quot;response_headers&quot;:&quot;[]&quot;,&quot;response&quot;:&quot;{\&quot;type\&quot;:\&quot;Object\&quot;,\&quot;children\&quot;:[{\&quot;name\&quot;:\&quot;RequestId\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E\&quot;},{\&quot;name\&quot;:\&quot;SQLDetails\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;Array\&quot;,\&quot;subType\&quot;:\&quot;Object\&quot;,\&quot;description\&quot;:\&quot;  \&quot;,\&quot;children\&quot;:[{\&quot;name\&quot;:\&quot;SQLText\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;SELECT  ****   FROM ****   WHERE **** = ? AND **** = ?   ORDER BY **** ASC\&quot;},{\&quot;name\&quot;:\&quot;DbName\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;testdb\&quot;},{\&quot;name\&quot;:\&quot;UserName\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;tester\&quot;}],\&quot;title\&quot;:\&quot;\&quot;}],\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;}&quot;,&quot;errors&quot;:&quot;{}&quot;}</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT  ****   FROM ****   WHERE **** = ? AND **** = ?   ORDER BY **** ASC</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tester</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
