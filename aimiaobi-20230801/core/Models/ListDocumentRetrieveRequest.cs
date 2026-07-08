// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListDocumentRetrieveRequest : TeaModel {
        /// <summary>
        /// <para>Document type. Valid values: 0 (default): All types. 1: Government documents. 2: Important articles. 5: Policy interpretation. 6: Legal provisions. 7: Regulations and rules. 8: General Secretary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>Search scope. Valid values: 1: Title only. 0: Full text (title and content). Default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ElementScope")]
        [Validation(Required=false)]
        public string ElementScope { get; set; }

        /// <summary>
        /// <para>End date of issuance in yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-03</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cEoBWREAXdxaOyjq/cqAbg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Issuing agency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>国务院办公室</para>
        /// </summary>
        [NameInMap("Office")]
        [Validation(Required=false)]
        public string Office { get; set; }

        /// <summary>
        /// <para>Search condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>检索Query</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Region. Enter a province or city, such as Jilin Province or Beijing Municipality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京市</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Source. Valid values: 0: Internal (within your organization). 1: External (outside your organization).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Start date of issuance in yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-10</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Secondary classification of document type.</para>
        /// <list type="bullet">
        /// <item><description><para>When the document type is an official document: -1: Other; 0: Resolution; 1: Decision; 2: Order; 3: Bulletin; 4: Public Notice; 5: Notice; 6: Opinion; 7: Notification; 8: Circular; 9: Report; 10: Request for Instructions; 11: Approval; 12: Motion; 13: Letter</para>
        /// </description></item>
        /// <item><description><para>14: Summary</para>
        /// </description></item>
        /// <item><description><para>When the article type is important articles: 1: important commentary 2: important theory 3: other articles</para>
        /// </description></item>
        /// <item><description><para>When the document genre is rules and regulations: 3: Administrative regulations 4: Supervisory regulations 5: Local regulations 7: Departmental rules 8: Others 9: Party constitution and regulations</para>
        /// </description></item>
        /// <item><description><para>When the article genre is a legal provision: 1: Constitution 2: Law 6: Judicial Interpretation</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SubContentType")]
        [Validation(Required=false)]
        public string SubContentType { get; set; }

        /// <summary>
        /// <para>Supported classifications:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Level 1 category</th>
        /// <th>Level 2 category</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>National defense and international cooperation</td>
        /// <td>National defense. Foreign affairs. Military affairs. Work related to Hong Kong, Macao, Taiwan, and overseas Chinese.</td>
        /// </tr>
        /// <tr>
        /// <td>Comprehensive administration</td>
        /// <td>The 20th National Congress of the Communist Party of China. Government transparency and supervision. Joint administration. Party building. Conferences and proposals. Government document management. Other administrative matters.</td>
        /// </tr>
        /// <tr>
        /// <td>State Council organizational structure</td>
        /// <td>State Council. General Office of the State Council. State Council agencies.</td>
        /// </tr>
        /// <tr>
        /// <td>Administrative and market regulation</td>
        /// <td>Administrative regulation. Credit regulation. Product quality supervision. Work safety supervision. Market regulation.</td>
        /// </tr>
        /// <tr>
        /// <td>Economic management</td>
        /// <td>National economy. Market economy. Economic system reform. State-owned asset supervision.</td>
        /// </tr>
        /// <tr>
        /// <td>Finance, banking, commerce, and customs</td>
        /// <td>Finance. Banking. Auditing. Commerce. Customs.</td>
        /// </tr>
        /// <tr>
        /// <td>Personnel and social security</td>
        /// <td>Personnel work. Population and family planning. Work related to women and children. Poverty alleviation. Disaster reduction and relief. Public services. Social welfare and assistance. Preferential treatment and resettlement. Social security.</td>
        /// </tr>
        /// <tr>
        /// <td>Public security and social management</td>
        /// <td>Public security. Safety. Justice. Fire control. Ethnic affairs. Religion.</td>
        /// </tr>
        /// <tr>
        /// <td>Science, education, culture, and sports</td>
        /// <td>Culture. Scientific and technological innovation. Education. Intellectual property. Press and publishing. Radio, television, and the Internet. Sports. Tourism.</td>
        /// </tr>
        /// <tr>
        /// <td>Healthcare</td>
        /// <td>Health. Medical care. Veterinary medicine.</td>
        /// </tr>
        /// <tr>
        /// <td>Urban-rural development and industrial growth</td>
        /// <td>Urban and rural development. Industry. Transportation.</td>
        /// </tr>
        /// <tr>
        /// <td>Natural resources and environmental protection</td>
        /// <td>Land and energy resources. Civil engineering. Meteorology. Environmental protection.</td>
        /// </tr>
        /// <tr>
        /// <td>Agriculture, forestry, water resources, fisheries, and animal husbandry</td>
        /// <td>Agriculture. Forestry. Water resources. Fisheries. Animal husbandry.</td>
        /// </tr>
        /// <tr>
        /// <td>Others</td>
        /// <td>Others.</td>
        /// </tr>
        /// </tbody></table>
        /// 
        /// <b>Example:</b>
        /// <para>国防和交流合作事务</para>
        /// </summary>
        [NameInMap("SubjectClassify")]
        [Validation(Required=false)]
        public string SubjectClassify { get; set; }

        /// <summary>
        /// <para>Document number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>宁民规〔2020〕5号</para>
        /// </summary>
        [NameInMap("WordSize")]
        [Validation(Required=false)]
        public string WordSize { get; set; }

        /// <summary>
        /// <para>Unique identifier of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get workspaceId</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
