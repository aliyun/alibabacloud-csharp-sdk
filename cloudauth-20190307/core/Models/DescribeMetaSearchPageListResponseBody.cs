// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaSearchPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The paginated list data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMetaSearchPageListResponseBodyItems> Items { get; set; }
        public class DescribeMetaSearchPageListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The product API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ID_CARD_2_META</b>: ID card two-element verification</description></item>
            /// <item><description><b>ID_PERIOD</b>: ID card validity period verification</description></item>
            /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: mobile number online duration</description></item>
            /// <item><description><b>MOBILE_ONLINE_STATUS</b>: mobile number online status</description></item>
            /// <item><description><b>MOBILE_3_META_SIMPLE</b>: mobile number three-element verification (simple edition)</description></item>
            /// <item><description><b>MOBILE_3_META</b>: mobile number three-element verification (detailed edition)</description></item>
            /// <item><description><b>MOBILE_2_META</b>: mobile number two-element verification</description></item>
            /// <item><description><b>BANK_CARD_N_META</b>: bank card verification (detailed edition)</description></item>
            /// <item><description><b>MOBILE_DETECT</b>: phone number detection </description></item>
            /// <item><description><b>VEHICLE_N_META</b>: vehicle element verification (enhanced edition)</description></item>
            /// <item><description><b>VEHICLE_PENTA_INFO</b>: vehicle five-element information recognition</description></item>
            /// <item><description><b>VEHICLE_LICENSE_INFO</b>: vehicle information recognition</description></item>
            /// <item><description><b>VEHICLE_INSURE_DATE</b>: vehicle insurance date query</description></item>
            /// <item><description><b>VEHICLE_CHECK</b>: vehicle element verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ID_CARD_2_META</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            /// <summary>
            /// <para>The name corresponding to the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ID_CARD_2_META</b>: ID card two-element verification</description></item>
            /// <item><description><b>ID_PERIOD</b>: ID card validity period verification</description></item>
            /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: mobile number online duration</description></item>
            /// <item><description><b>MOBILE_ONLINE_STATUS</b>: mobile number online status</description></item>
            /// <item><description><b>MOBILE_3_META_SIMPLE</b>: mobile number three-element verification (simple edition)</description></item>
            /// <item><description><b>MOBILE_3_META</b>: mobile number three-element verification (detailed edition)</description></item>
            /// <item><description><b>MOBILE_2_META</b>: mobile number two-element verification</description></item>
            /// <item><description><b>BANK_CARD_N_META</b>: bank card verification (detailed edition)</description></item>
            /// <item><description><b>MOBILE_DETECT</b>: phone number detection </description></item>
            /// <item><description><b>VEHICLE_N_META</b>: vehicle element verification (enhanced edition)</description></item>
            /// <item><description><b>VEHICLE_PENTA_INFO</b>: vehicle five-element information recognition</description></item>
            /// <item><description><b>VEHICLE_LICENSE_INFO</b>: vehicle information recognition</description></item>
            /// <item><description><b>VEHICLE_INSURE_DATE</b>: vehicle insurance date query</description></item>
            /// <item><description><b>VEHICLE_CHECK</b>: vehicle element verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>身份证二要素</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The bank card ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6214837145546986</para>
            /// </summary>
            [NameInMap("BankCard")]
            [Validation(Required=false)]
            public string BankCard { get; set; }

            /// <summary>
            /// <para>The verification status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification passed.</description></item>
            /// <item><description><b>2</b>: Verification failed.</description></item>
            /// <item><description><b>3</b>: No record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The verification date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-17 10:00:11</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The ID card number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4****************X</para>
            /// </summary>
            [NameInMap("IdentifyNum")]
            [Validation(Required=false)]
            public string IdentifyNum { get; set; }

            /// <summary>
            /// <para>The name of the telecommunications service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile</description></item>
            /// <item><description><b>CUCC</b>: China Unicom</description></item>
            /// <item><description><b>CTCC</b>: China Telecom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>The mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500000xxxx</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The request parameters.</para>
            /// </summary>
            [NameInMap("Request")]
            [Validation(Required=false)]
            public DescribeMetaSearchPageListResponseBodyItemsRequest Request { get; set; }
            public class DescribeMetaSearchPageListResponseBodyItemsRequest : TeaModel {
                /// <summary>
                /// <para>The vehicle number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙J3H91H</para>
                /// </summary>
                [NameInMap("VehicleNum")]
                [Validation(Required=false)]
                public string VehicleNum { get; set; }

                /// <summary>
                /// <para>The vehicle type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>01</b>: large vehicle  </description></item>
                /// <item><description><b>02</b>: small vehicle  </description></item>
                /// <item><description><b>03</b>: embassy vehicle  </description></item>
                /// <item><description><b>04</b>: consulate vehicle  </description></item>
                /// <item><description><b>05</b>: overseas vehicle  </description></item>
                /// <item><description><b>06</b>: foreign vehicle  </description></item>
                /// <item><description><b>07</b>: standard motorcycle  </description></item>
                /// <item><description><b>08</b>: light motorcycle  </description></item>
                /// <item><description><b>09</b>: embassy motorcycle  </description></item>
                /// <item><description><b>10</b>: consulate motorcycle  </description></item>
                /// <item><description><b>11</b>: overseas motorcycle  </description></item>
                /// <item><description><b>12</b>: foreign motorcycle  </description></item>
                /// <item><description><b>13</b>: low-speed vehicle  </description></item>
                /// <item><description><b>14</b>: tractor  </description></item>
                /// <item><description><b>15</b>: trailer  </description></item>
                /// <item><description><b>16</b>: training vehicle  </description></item>
                /// <item><description><b>17</b>: training motorcycle  </description></item>
                /// <item><description><b>20</b>: temporary entry vehicle  </description></item>
                /// <item><description><b>21</b>: temporary entry motorcycle  </description></item>
                /// <item><description><b>22</b>: temporary driving vehicle  </description></item>
                /// <item><description><b>23</b>: police vehicle  </description></item>
                /// <item><description><b>24</b>: police motorcycle  </description></item>
                /// <item><description><b>51</b>: new energy large vehicle  </description></item>
                /// <item><description><b>52</b>: new energy small vehicle.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>52</para>
                /// </summary>
                [NameInMap("VehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

                /// <summary>
                /// <para>The vehicle type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>新能源小型车</para>
                /// </summary>
                [NameInMap("VehicleTypeName")]
                [Validation(Required=false)]
                public string VehicleTypeName { get; set; }

            }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B0102BEF-4411-57C3-860D-CFE7DE0A64C0</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The HTTP request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;productCode\&quot;:\&quot;cloudauth_infoverify_public_cn\&quot;,\&quot;identifyNum\&quot;:\&quot;4****************X\&quot;,\&quot;userName\&quot;:\&quot;**豪\&quot;,\&quot;userId\&quot;:\&quot;12600512516xxxxx\&quot;}</para>
            /// </summary>
            [NameInMap("RequestJson")]
            [Validation(Required=false)]
            public string RequestJson { get; set; }

            /// <summary>
            /// <para>The response content.</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public DescribeMetaSearchPageListResponseBodyItemsResponse Response { get; set; }
            public class DescribeMetaSearchPageListResponseBodyItemsResponse : TeaModel {
                /// <summary>
                /// <para>The HTTP return code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public DescribeMetaSearchPageListResponseBodyItemsResponseData Data { get; set; }
                public class DescribeMetaSearchPageListResponseBodyItemsResponseData : TeaModel {
                    /// <summary>
                    /// <para>The approved number of passengers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ApprovedCount")]
                    [Validation(Required=false)]
                    public string ApprovedCount { get; set; }

                    /// <summary>
                    /// <para>The approved passenger capacity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ApprovedLoad")]
                    [Validation(Required=false)]
                    public string ApprovedLoad { get; set; }

                    /// <summary>
                    /// <para>The number of axles.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AxleCount")]
                    [Validation(Required=false)]
                    public string AxleCount { get; set; }

                    /// <summary>
                    /// <para>The rear wheel track.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1630</para>
                    /// </summary>
                    [NameInMap("BackWheelDistance")]
                    [Validation(Required=false)]
                    public string BackWheelDistance { get; set; }

                    /// <summary>
                    /// <para>The bank card number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>622848001714440xxxx</para>
                    /// </summary>
                    [NameInMap("BankCard")]
                    [Validation(Required=false)]
                    public string BankCard { get; set; }

                    /// <summary>
                    /// <para>The verification status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: Verification passed.</description></item>
                    /// <item><description><b>2</b>: Verification failed.</description></item>
                    /// <item><description><b>3</b>: No record found.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    /// <summary>
                    /// <para>The brand name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>奔驰</para>
                    /// </summary>
                    [NameInMap("Brand")]
                    [Validation(Required=false)]
                    public string Brand { get; set; }

                    /// <summary>
                    /// <para>The body color.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>白</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <para>The displacement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Displacement")]
                    [Validation(Required=false)]
                    public string Displacement { get; set; }

                    /// <summary>
                    /// <para>The engine number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N7YJ113PA</para>
                    /// </summary>
                    [NameInMap("EngineNum")]
                    [Validation(Required=false)]
                    public string EngineNum { get; set; }

                    /// <summary>
                    /// <para>The engine model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA6GV30TD</para>
                    /// </summary>
                    [NameInMap("EngineType")]
                    [Validation(Required=false)]
                    public string EngineType { get; set; }

                    /// <summary>
                    /// <para>The front wheel track.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1630</para>
                    /// </summary>
                    [NameInMap("FrontWheelDistance")]
                    [Validation(Required=false)]
                    public string FrontWheelDistance { get; set; }

                    /// <summary>
                    /// <para>The fuel type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>电</para>
                    /// </summary>
                    [NameInMap("FuelType")]
                    [Validation(Required=false)]
                    public string FuelType { get; set; }

                    /// <summary>
                    /// <para>The inspection validity expiration date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-07-31 00:00:00</para>
                    /// </summary>
                    [NameInMap("InspectionDate")]
                    [Validation(Required=false)]
                    public string InspectionDate { get; set; }

                    /// <summary>
                    /// <para>The vehicle model number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HQ7002BEV67</para>
                    /// </summary>
                    [NameInMap("ModelNum")]
                    [Validation(Required=false)]
                    public string ModelNum { get; set; }

                    /// <summary>
                    /// <para>The power.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Power")]
                    [Validation(Required=false)]
                    public string Power { get; set; }

                    /// <summary>
                    /// <para>The initial registration date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2015-08-24 00:00:00</para>
                    /// </summary>
                    [NameInMap("RegistrationDate")]
                    [Validation(Required=false)]
                    public string RegistrationDate { get; set; }

                    /// <summary>
                    /// <para>The manufacturing date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-08-13 00:00:00</para>
                    /// </summary>
                    [NameInMap("ReleaseDate")]
                    [Validation(Required=false)]
                    public string ReleaseDate { get; set; }

                    /// <summary>
                    /// <para>The mandatory retirement date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2099-12-31 00:00:00</para>
                    /// </summary>
                    [NameInMap("RetirementDate")]
                    [Validation(Required=false)]
                    public string RetirementDate { get; set; }

                    /// <summary>
                    /// <para>The gross mass.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2350</para>
                    /// </summary>
                    [NameInMap("TotalMass")]
                    [Validation(Required=false)]
                    public string TotalMass { get; set; }

                    /// <summary>
                    /// <para>The vehicle type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>小型轿车</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The curb weight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1900</para>
                    /// </summary>
                    [NameInMap("UnladenMass")]
                    [Validation(Required=false)]
                    public string UnladenMass { get; set; }

                    /// <summary>
                    /// <para>The usage property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UseProperty")]
                    [Validation(Required=false)]
                    public string UseProperty { get; set; }

                    /// <summary>
                    /// <para>The motor vehicle status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>正常</para>
                    /// </summary>
                    [NameInMap("VehicleState")]
                    [Validation(Required=false)]
                    public string VehicleState { get; set; }

                    /// <summary>
                    /// <para>The vehicle identification number (VIN).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LDC643T44G3667219</para>
                    /// </summary>
                    [NameInMap("Vin")]
                    [Validation(Required=false)]
                    public string Vin { get; set; }

                    /// <summary>
                    /// <para>The wheelbase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2750</para>
                    /// </summary>
                    [NameInMap("WheelBase")]
                    [Validation(Required=false)]
                    public string WheelBase { get; set; }

                }

                /// <summary>
                /// <para>The message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The response content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;code\&quot;:\&quot;200\&quot;,\&quot;data\&quot;:{\&quot;bizCode\&quot;:\&quot;1\&quot;,\&quot;ispName\&quot;:\&quot;CMCC\&quot;,\&quot;subCode\&quot;:\&quot;101\&quot;},\&quot;message\&quot;:\&quot;调用成功\&quot;}</para>
            /// </summary>
            [NameInMap("ResponseJson")]
            [Validation(Required=false)]
            public string ResponseJson { get; set; }

            /// <summary>
            /// <para>The result code. For more information, see <a href="https://www.alibabacloud.com/help/en/id-verification/information-verification/">official documentation</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>207</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**豪</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The vehicle number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙J3H91H</para>
            /// </summary>
            [NameInMap("VehicleNum")]
            [Validation(Required=false)]
            public string VehicleNum { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5176EB42-6EE7-510B-9388-35018DF3175B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
